function getCoaches() {
    var $li = $('ul#search-keywords').find('li');
    var ids = $li.map(function(index, li) {
        return $(li).data('id');
    });
    var base = 'http://localhost:29071/api/coaches?';
    var qs = ids.map(function(index, id) {
        return 'keyword=' + id;
    }).toArray().join('&');
    var url = base + qs;
    $.getJSON(url).done(function(result) {
        var markup = $('#coachTmpl').text();
        var tmpl = _.template(markup);
        var html = result.map(function(coach) {
            return tmpl(coach);
        }).join('');
        $(document).find('#search-results').find('ol').html(html);
        $(document).find('#testimonial').hide();
        $(document).find('#search-results').show();
        
    });
};