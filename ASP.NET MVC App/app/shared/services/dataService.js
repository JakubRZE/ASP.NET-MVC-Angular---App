(function () {
    'use strict';

    angular
        .module('app')
        .factory('dataService', ['$http', '$q', function($http, $q) {
            var service = {};

            service.getProducts = function() {
                var deferred = $q.defer();
                $http.get('/Product/Products').then(function(result) {
                    deferred.resolve(result.data);
                }, function() {
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