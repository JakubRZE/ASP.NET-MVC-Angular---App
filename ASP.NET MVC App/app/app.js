(function () {
    'use strict';

    angular.module('app',
            [
                'ngRoute'
            ])
        .config([
            '$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
                $locationProvider.hashPrefix('');
                $routeProvider
                    .when('/',
                        {
                            controller: 'productController',
                            templateUrl: '/app/Products/products.html'
                        })
                    .otherwise({ redirectTo: '/' });
            }
        ]);
})();