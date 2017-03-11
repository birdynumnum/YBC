businesscardModule.controller("SearchCardController", function ($scope, cardsRepository, notificationService) {

    $scope.Find = function () {
        cardsRepository.search($scope.key).then(function (foundcards) {

            console.log(foundcards.length);
            $scope.foundcards = foundcards;

            if ($scope.foundcards.length != 0) {

                notificationService.displaySuccess("Found " + $scope.foundcards.length + " Cards");
            }
            else notificationService.displayInfo("No matching cards found");
        },
       function (error) {
           notificationService.displayError("Error obtaining cards"); console.log("Error retrieving data");
       });
    };
});