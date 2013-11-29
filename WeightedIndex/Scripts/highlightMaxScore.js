
function highlightMaxScore() {
    
    // read the scores
    var scoreArray = arrayFromScores();
    
    // find the max score
    var maxScore = getMaxScoreFromArray(scoreArray);

    // highlight the row with the max score
    highlightRowWithScore(maxScore);

}

// reads the scores from the page and
// returns them as an array
function arrayFromScores() {

    var scoreArray = new Array();

    // for each of the scores
    $('.score').each(function (index, value) { // hard-coded value is used because this is a sample
        // store the value
        scoreArray[index] = $(this).text;
    });
    
    return scoreArray;
}

// returns the highest score in the array
function getMaxScoreFromArray(scoreArray) {
    return Math.max.apply(null, scoreArray);
}

// highlights the row with the given score
function highlightRowWithScore(score) {
    // for each row
    $('.row').each(function (value) {
        // if the score matches, highlight it
        if (value == score) {
            $(this).class($(this).class() + ' .highlighted');
        }
    });
}