var app = angular.module('app', ['ngTouch', 'ui.grid']);
 
app.controller('MainCtrl', ['$scope', '$http',function ($scope, $http) {
    $scope.gridOptions = {

    };
    
    $scope.gridOptions.columndefs = [
        
        {name: 'eventnumber'},
        {name: 'eventname'},
        {name: 'featuretextdescription'},
        {name: 'price'},
        {name: 'eventcategory' },
        { name: 'eventdatestarttime'},
        { name: 'maximumplayers'}


    ];
    $http.get("/api/v1/events")
        .success(function(data) {
              $scope.gridOptions.data = data;
            });

}]);

