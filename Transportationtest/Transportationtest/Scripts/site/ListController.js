(function () {
    'use strict'

    angular.module(AppName).controller("list", ListController)
    ListController.$inject = ["$scope", "$state", "$window","transportationService"]; 

    function ListController($scope, $state, $window, transportationService) {
        var vm = this; 
        vm.$scope = $scope;
        vm.$state = $state; 
        vm.$oninit = _init; 


        function _init() {
        }
    }


})();
