(function () {
    'use strict';

    angular
        .module('app')
        .controller('productController',
            [
                '$scope', 'dataService', function($scope, dataService) {
                    $scope.products = [];
                    $scope.categories = [];
                    $scope.orders = [];
                    $scope.prod = '';


                    getProducts();
                    getCategories();

                    $scope.onRowClick = function (row) {
                        getOrders(row.Id);
                        $scope.prod = row.Name;
                        $('#order-modal').modal('show');
                    }

                    function getProducts() {
                        dataService.getProducts().then(function(result) {
                            $scope.products = result;
                        });
                    }

                    function getCategories() {
                        dataService.getCategories().then(function (result) {
                            $scope.categories = result;
                        });
                    }

                    function getOrders(id) {
                        dataService.getOrders(id).then(function (result) {
                            $scope.orders = result;
                        });
                    }
                }
            ]);
})();
