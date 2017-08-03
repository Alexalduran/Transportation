(function () {
    'use strict'

    angular.module(AppName).controller("edit", EditController)
    EditController.$inject = ["$scope", "$state", "$window", "transportationService"];

    function EditController($scope, $state, $window, transportationService) {
        var vm = this;
        vm.$scope = $scope;
        vm.$state = $state;
        vm.get = _get;
        vm.$oninit = _init;
        vm.tObj = { Name: "", TransportType: "", TransportMode: "", PowerSource: "" }
        vm.capacity = {};
        vm.post = _post;
        vm.items = []; 
        vm.edit = _edit;
        vm.delete = _delete; 

        function _delete(data) {
            transportationService.delete(data).then(function (response) {
                console.log("yey");
            })
        }

        function _init() {

        };

        function _edit(data) {
            console.log("edit", data);
            console.log("capacity", data.Capacity[0].UnitOfMeasure);
            vm.tObj = {}
            vm.capacityData = [];
            vm.capacity = {};
            if (data != null) {
                vm.tObj.Name = data.Name;
                vm.tObj.TransportType = data.TypeOfTransportString;
                vm.tObj.TransportMode = data.TypeOfTransportMode;
                vm.tObj.PowerSource = data.TypeOfPowerSource;
                vm.capacity.Count = data.Capacity[0].Count;
                vm.capacity.UnitofMeasure = data.Capacity[0].UnitOfMeasure;
                vm.capacity.PassengerType = data.Capacity[0].PassengerType;

            }
        }
        

        function _post(tObj, capacity) {
            vm.capacityData = [];
            vm.capacityData.push(capacity);
            vm.transportation = { Name: tObj.Name, TransportType: tObj.TransportType, TransportMode: tObj.TransportMode, PowerSource: tObj.PowerSource, Capacity: vm.capacityData };
            console.log(vm.transportation);
            transportationService.post(vm.transportation).then(function (response) {
                //console.log("response", response)
                vm.items = response.data;
                console.log("items", vm.items);
                return response;

            })
        }

        function _get() {
            transportationService.get().then(function (data) {
                console.log(data);
            })
        }

    }
})();