(function () {

    //Create Module
    var app = angular.module('MyApp', ['ngRoute']);
    //Create Controller 

    app.controller('BeerController', function ($scope) {
        
        $scope.Message = "Worked";

    });


})();