function MeasureViewController() {
}

// static function acting as ViewController for Index
MeasureViewController.Index = function () {

    // get the data
    var measureDataAccessObject = new MeasureDataAccessObject();
    var measureJsonArray = measureDataAccessObject.getAllAsJsonArray();

    // create the model
    var indexViewModel =  new IndexViewModel(measureJsonArray);

    // bind
    ko.applyBindings(indexViewModel);
};