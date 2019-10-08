(function () {
    'use strict';

    angular
        .module('app')
        .factory('dataService', ['$http', '$q', function($http, $q) {
            var service = {};

            service.getProducts = function (searchString, category, downPrice, upPrice) {
                var deferred = $q.defer();
                $http({
                    url: '/Product/Products/',
                    method: "GET",
                    params: {
                        SearchString: searchString,
                        Category: category,
                        DownPrice: downPrice,
                        UpPrice: upPrice
                    }
                }).then(function (result) {
                    deferred.resolve(result.data);
                }, function() {
                    deferred.reject();
                    });
                return deferred.promise;
            };

            service.getCategories = function () {
                var deferred = $q.defer();
                $http.get(`/Product/Categories`).then(function (result) {
                    deferred.resolve(result.data);
                }, function () {
                    deferred.reject();
                });
                return deferred.promise;
            };

            service.getOrders = function (id) {
                var deferred = $q.defer();
                $http.get(`/Product/Orders/${id}`).then(function (result) {
                    deferred.resolve(result.data);
                }, function () {
                    deferred.reject();
                });
                return deferred.promise;
            };

            return service;
        }]);
})();