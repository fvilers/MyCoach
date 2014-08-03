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

            if (result.length === pageSize) {
                $('#loadingSection').show();
            }
            

            if (typeof callback === 'function') {
                callback(result.length < pageSize);
            }
            
        });
    }
})();


$(document)
.on('click', '#loadingSection button', function loadNext(e) {
    $(e.target).parent('#loadingSection').hide();


    getCoaches(null, function(hasFinished) {
        $(e.target).parent('#loadingSection').show();

        if (hasFinished) {
            $(e.target).parent('#loadingSection').hide();
            $(document).off('click', '#loadingSection button', loadNext);
        }
    });
})
.on('click', 'a.booking-coach', function (e) {
    e.preventDefault();
    var coachId = $(e.target).parents('#pophover').children('section').data('id');
    var url = '/api/coaches/' + coachId;
    $.getJSON(url).done(function (result) {
        if (!!result) {
            var markup = $('#paymentTemplate').html();
            var tmpl = _.template(markup);
            var html = tmpl(result);
            $('#pophover').empty().html(html);            
        }

    });

});
