var app = angular.module('app', ['ngTouch', 'ui.grid']);
 
app.controller('MainCtrl', ['$scope', function ($scope) {
    
    $scope.gridOptions.columndefs = [
        {name: 'id'},
        {name: 'eventnumber'},
        {name: 'eventname'},
        {name: 'featuretextdescription'},
        {name: 'price'},
        {name: 'eventcategory'}
    ];
    $http.get("/api/v1/events")
        .success(function(data) {
              $scope.gridOptions.data = data;
            });

}]);

