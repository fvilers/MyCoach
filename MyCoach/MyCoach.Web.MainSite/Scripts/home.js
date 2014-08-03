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
        $.getJSON(url).done(function (data) {
            var allFetched = data.allFetched;
            var result = data.coaches;
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

            if (result.length > 0) {
                $(document).find('#search-results').show();

                currentPage++;

                if (!allFetched) {
                    $('#loadingSection').show();
                }


                if (typeof callback === 'function') {
                    callback(allFetched);
                }
            } else {
                $('#loadingSection').hide();
            }


        });
    }
})();


$(document)
.on('click', '#loadingSection button', function loadNext(e) {
    $(e.target).parent('#loadingSection').hide();


    getCoaches(null, function (hasFinished) {
        $(e.target).parent('#loadingSection').show();

        if (hasFinished) {
            $(e.target).parent('#loadingSection').hide();
            //$(document).off('click', '#loadingSection button', loadNext);
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

window.substringMatcher = function (strs) {
    return function findMatches(q, cb) {
        var matches, substrRegex;

        matches = [];
        substrRegex = new RegExp(q, 'i');

        $.each(strs, function (i, item) {
            if (substrRegex.test(item.name)) {
                if ($('#search-keywords li:contains(' + item.name + ')').length == 0) {
                    matches.push(item);
                }
            }
        });

        cb(matches);
    };
};

$(function () {
    $.getJSON('http://localhost:29071/api/expertise-domains').done(function (data) {
        $('#search-input').typeahead({
            hint: true,
            hightlight: false,
            minLength: 2
        }, {
            displayKey: 'name',
            name: 'keywords',
            source: substringMatcher(data),
        }).bind("typeahead:autocompleted", function (event, selectedItem) {
            var $li = $('<li></li>');

            $li.data('id', selectedItem.id);
            $li.text(selectedItem.name);
            $('#search-keywords').append($li);
            $(this).typeahead('val', '');
            getCoaches(1);
            $(this).attr('placeholder', '');
        }).keyup(function (e) {
            if (e.keyCode == 8 && $(this).val() == '') {
                $('#search-keywords li:last').remove();

                if ($('#search-keywords li').length == 0) {
                    $('#search-results ol li').remove();
                    $(this).blur().focus();
                } else {
                    getCoaches();
                };
            }
        }).focus();
    });

    $('form div').click(function () {
        $('#search-input').focus();
    });

    $(document).on('click', '.coachSnap', function () {
        var id = $(this).data('id');

        $.getJSON('http://localhost:29071/api/coaches/' + id).done(function (data) {
            var markup = $('#pophoverTemplate').text();
            var tmpl = _.template(markup);
            var html = tmpl(data);

            $('#home').append(html);
            $('#pophover').show();
        });
    });

    $(document).on('click', '#close', function () {
        $('#pophover').remove();
    });
});
