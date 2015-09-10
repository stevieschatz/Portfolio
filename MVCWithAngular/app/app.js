angular.module('app', ['MVCWithAngular.HomeController'])
    .directive('loadingButton', function(){

        return {

            restrict: 'A',
            scope: {
                spin: '='
            },
            link: function (scope, element, attrs) {

                $(element).ladda();

                scope.$watch('spin', function (newValue, oldValue) {


                    if (newValue) {
                        $(element).ladda('start');
                    }
                    else {

                        $(element).ladda('stop');

                    }

                });

            }

            };
});