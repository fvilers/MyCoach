window.getCoaches = (function () {
    var currentPage = 1;
    var pageSize = 2; //always
    return function (page, callback) {
        if (typeof page === 'number') {
            currentPage = page;
        } else {
            page = currentPage;
        }
        var $li = $('ul#search-keywords').find('li');
        var ids = $li.map(function (index, li) {
            return $(li).data('id');
        });
        var base = 'http://localhost:29071/api/coaches?';
        var qs = ids.map(function (index, id) {
            return 'keyword=' + id;
        }).toArray().concat('page=' + page, 'pageSize=' + pageSize);
        var url = base + qs.join('&');
        $.getJSON(url).done(function (result) {
            var markup = $('#coachTmpl').text();
            var tmpl = _.template(markup);
            var html = result.map(function (coach) {
                return tmpl(coach);
            }).join('');
            if (page === 1) {
                $(document).find('#search-results').find('ol').html(html);
            } else {
                $(document).find('#search-results').find('ol').append(html);
            }

            $(document).find('#testimonial').hide();
            $(document).find('#search-results').show();

            currentPage++;

            if (typeof callback === 'function') {
                callback();
            }
            
        });
    }
})();


function getNextCoaches() {
    var load = false; // aucun chargement de commentaire n'est en cours
    var maxReached = false;
 
    /* la fonction offset permet de récupérer la valeur X et Y d'un élément
	dans une page. Ici on récupère la position du dernier div qui 
	a pour classe : ".commentaire" */
    var offset = $('li.coach:last').offset();

    $(window).scroll(function() { // On surveille l'évènement scroll

        /* Si l'élément offset est en bas de scroll, si aucun chargement 
		n'est en cours, si le nombre de commentaire affiché est supérieur 
		à 5 et si tout les commentaires ne sont pas affichés, alors on 
		lance la fonction. */
        if ((offset.top - $(window).height() <= $(window).scrollTop())
            && load == false && ($('li.coach').size() > 0) && !maxReached) {

            // la valeur passe à vrai, on va charger
            load = true;

            //On récupère l'id du dernier commentaire affiché
            var last_id = $('li.coach:last').data('id');

            //On affiche un loader
            //$('.loadmore').show();

            //On lance la fonction ajax
            //$.ajax({});
            //var markup = $('#coachTmpl').text();
            //var tmpl = _.template(markup);
            //var html = '<li class="coach" data-id="X">sdqfqsdfqsdfqsdfdsq</li>';
            //$(document).find('#search-results').find('ol').append(html);


            getCoaches(null, function() {
                offset = $('li.coach:last').offset();
                //On remet la valeur à faux car c'est fini
                load = false;
            });

            //offset = $('li.coach:last').offset();
            ////On remet la valeur à faux car c'est fini
            //load = false;
        }
    });
}