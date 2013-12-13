var MeasureDataAccessObject = function () {

    // URL path to get all measures as JSON
    var GET_ALL_JSON_PATH = "/Measure/getAllAsJson";

    // gets all of the measures as an array
    this.getAllAsJsonArray = function () {

        var jsonArray = [];

        $.ajax({
            type: "POST",
            url: GET_ALL_JSON_PATH,
            async: false,
            dataType: 'json'
        }).done(function (data) {
             jsonArray = data;
        });

        // return parsed JSON
        return jsonArray;
    };
};