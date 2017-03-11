businesscardModule.factory('CardIDService', function ($http, $q) {
    return {
        getItem: function (Id) {
            var deferred = $q.defer();
            $http.get('/Cards/GetCard/' + Id.Id).success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }
    }
})
