angular.module('MVCWithAngular.HomeController', [])
.controller('HomeController', ['$scope','$http', function ($scope, $http) {

    $scope.model = {};

    


    $http.get('/Home/IndexVM').success(function(data) {

        $scope.model = data;
    
    });

}]);