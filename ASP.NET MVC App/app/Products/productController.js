(function () {
    'use strict';

    angular
        .module('app')
        .controller('productController',
            [
                '$scope', 'dataService', function ($scope, dataService) {
                    $scope.products = [];
                    $scope.categories = [];
                    $scope.orders = [];
                    $scope.prod = '';

                    $scope.sortOrder = 'Asc';
                    $scope.sortParam = 'Name';

                    $scope.searchString = null;
                    $scope.category = null;
                    $scope.downPrice = null;
                    $scope.upPrice = null;


                    getProducts($scope.searchString, $scope.category, $scope.downPrice, $scope.upPrice, $scope.sortParam, $scope.sortOrder);
                    getCategories();

                    $scope.onRowClick = function (row) {
                        getOrders(row.Id);
                        $scope.prod = row.Name;
                        $('#order-modal').modal('show');
                    }

                    $scope.submitFilters = function () {
                        getProducts($scope.searchString, $scope.category, $scope.downPrice, $scope.upPrice, $scope.sortParam, $scope.sortOrder);
                    }

                    $scope.onHeaderClick = function(name) {
                        if ($scope.sortParam === name)
                            ($scope.sortOrder === 'Asc') ? $scope.sortOrder = 'Desc' : $scope.sortOrder = 'Asc';
                        else
                            $scope.sortParam = name;

                        getProducts($scope.searchString, $scope.category, $scope.downPrice, $scope.upPrice, $scope.sortParam, $scope.sortOrder);
                    }

                    function getProducts(searchString, category, downPrice, upPrice, sortParam, sortOrder) {
                        dataService.getProducts(searchString, category, downPrice, upPrice, sortParam, sortOrder).then(function (result) {
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
