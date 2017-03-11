businesscardModule.controller("CardsController", function ($scope, cardsRepository, notificationService) {

    cardsRepository.get().then(function (cards) {
        $scope.cards = cards;
        notificationService.displaySuccess("Got all Cards");
    },
    function (error) {
        notificationService.displayError("Error obtaining cards"); console.log("Error retrieving data");
    });

});