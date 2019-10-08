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

                    $scope.sortOrder = 'Asc';
                    $scope.sortParam = 'Name';

                    $scope.searchString = null;
                    $scope.category = null;
                    $scope.downPrice  = null;
                    $scope.upPrice = null;


                    getProducts($scope.searchString, $scope.category, $scope.downPrice, $scope.upPrice);
                    getCategories();

                    $scope.onRowClick = function (row) {
                        getOrders(row.Id);
                        $scope.prod = row.Name;
                        $('#order-modal').modal('show');
                    }

                    $scope.submitFilters = function () {
                        console.log($scope.searchString, $scope.category, $scope.downPrice, $scope.upPrice);

                        getProducts($scope.searchString, $scope.category, $scope.downPrice, $scope.upPrice);
                    }


                    //

                    function onHeaderClick(name) {

                    }

                    function getProducts(searchString, category, downPrice, upPrice) {

                        dataService.getProducts(searchString, category, downPrice, upPrice).then(function(result) {
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
