"use strict";

// ViewModel for the Index page for Measures

var IndexViewModel = function (inputMeasureArray) {

    // the path for editing a measure
    var MEASURE_EDIT_PATH = '/Measure/Edit/';

    var MEASURE_DELETE_PATH = '/Measure/Delete/';

    // define a working measure array variable to protect the input measure array variable
    var workingMeasureArray = inputMeasureArray;
     
    // gets the highest score in the array
    var getHighestScore = function () {
        var highestScore = null;

        for (var measure in workingMeasureArray) {

            var isFirstMeasure = (highestScore === null);

            if (isFirstMeasure) {
                // set the highest score to the current measure's score
                highestScore = measure.getScore();
            }

            else if (!isFirstMeasure) {

                var isNewHighestScore = (measure.getScore() > highestScore);

                if (isNewHighestScore) {
                    // change the current highest score to the measure's score
                    highestScore = measure.getScore();
                }
                else {
                    // do nothing
                }
            }

            else {
                // something unexpected happened
            }
        } // for

        return highestScore;
    };

    // the public version of the array for KnockoutJS
    this.measureObservableArray = ko.observableArray(workingMeasureArray);

    // goes to the edit view
    this.edit = function (measure) {
        // direct the browser to the edit view
        window.location.href = MEASURE_EDIT_PATH + measure.id;
    };

    // deletes the measure
    this.delete = function (measure) {
        // direct the browser to the URL for deleting the measure
        window.location.href = MEASURE_DELETE_PATH + measure.id;
    };

    // determines whether or not a measure has the highest score
    this.hasHighestScore = function (measure) {
        return (measure.score === getHighestScore());
    };
}; 