(function () {

    angular.module(AppName).factory("transportationService", TransportationService)
    TransportationService.$inject = ["$http", "$q"]; 

    function TransportationService($http, $q) {
        var ts = {
            get: _get,
            post: _post,
            delete: _delete
        }
        return ts;

        function _delete(data) {
            console.log("delete", data)
            return $http({
                url: "/Home/DeleteTransportation",  // "/Controller/Action/"
                params: { transportationName: data },
                method: "POST"
            })
            function deleteSuccess(response) {
                return response; 
            }
            function deleteError(response) {
                return $q.reject.response;
            }
        }

        function _post(data) {
           return $http.post("/Home/AddTransportation/", data)
                .then(postSuccess)
                .catch(postError); 
            function postSuccess(response) {
                return response;
            }

            function postError(response) {
               return $q.reject(response);
            }
        }

        function _get() {
            return $http({
                url: "/Home/AddTransportation",  // "/Controller/Action/"
                params: { name: "something" },
                method: "GET"
            })
                .then(getSuccess)
                .catch(getError);
            function getSuccess(response) {
                return response; 
            }
            function getError(response) {
                return $q.reject.response;
            }
        }
    }

})()