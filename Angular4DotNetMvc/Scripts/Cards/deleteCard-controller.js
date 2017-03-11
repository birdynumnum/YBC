businesscardModule.controller('deleteCardController', function ($scope, item, cardsRepository, notificationService) {

    $scope.item = item;

    cardsRepository.deleteCard($scope.item).then(function () {
        notificationService.displaySuccess("Deleted Card");
    },
  function (error) {
      notificationService.displayError("Error deleting card"); console.log("Error deleting data");
  });
});