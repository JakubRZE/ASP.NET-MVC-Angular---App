(function () {
    'use strict';

    angular
        .module('app')
        .controller('productController',
            [
                '$scope', 'dataService', function($scope, dataService) {
                    $scope.products = [];
                    $scope.orders = [];
                    $scope.prod = '';


                    getProducts();

                    function getProducts() {
                        dataService.getProducts().then(function(result) {
                            $scope.products = result;
                        });
                    }

                    $scope.onRowClick = function (row) {
                        getOrders(row.Id);
                        $scope.prod = row.Name;
                        $('#order-modal').modal('show');
                    }

                    function getOrders(id) {
                        dataService.getOrders(id).then(function (result) {
                            $scope.orders = result;
                        });
                    }
                }
            ]);
})();
