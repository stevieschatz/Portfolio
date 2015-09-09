angular.module('MVCWithAngular.HomeController', [])
.controller('HomeController', ['$scope','$http', function ($scope, $http) {

    $scope.model = {};
    $scope.states = {

        showBeerForm: false
    };


   

   
    
    $scope.new = {

        Beer: {}
    };

    $http.get('/Home/IndexVM').success(function(data) {

        $scope.model = data;
    
    });

    $scope.showBeerForm = function (show) {

        $scope.states.showBeerForm = show;
    };

    $scope.addBeer = function () {

        $http.post("/Home/Edit", $scope.new.Beer).success(function (data) {

            $scope.model.Beers.push(data);

        });
    }

    }]);