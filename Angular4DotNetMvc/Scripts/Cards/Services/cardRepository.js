businesscardModule.factory('cardsRepository', function ($http, $q) {
    return {
        get: function () {
            var deferred = $q.defer();
            $http.get('/Cards').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        },

        post: function (newCard) {
            var deferred = $q.defer();
            $http({
                url: '/Cards/Create',
                method: 'Post',
                data: newCard
            }).success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        },

        deleteCard: function (card) {
            var deferred = $q.defer();
            var id = card.value.id;
            $http({
                url: '/Cards/Delete/' + id,
                method: 'Post',
                data: id,
            }).success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        },

     
        search: function (key) {
            var params = { key : key};
            var deferred = $q.defer();
            $http({
                url: '/Cards/Search/',
                method: 'Get',
                params : params
            }).success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }
      
    };
});