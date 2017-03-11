(function (app) {
    'use strict';

    app.controller("addCardsController", addCardsController);

    addCardsController.$inject = ['$scope', '$window', 'cardsRepository'];
    function addCardsController($scope, $window, cardsRepository) {


        $scope.submitForm = function (cards) {
            cardsRepository.post(cards);
            $window.history.back();
        }

        $scope.cancelForm = function () {
            $window.history.back();
        }
    }
})(angular.module('businesscardModule'));