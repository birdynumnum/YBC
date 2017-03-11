var businesscardModule = angular.module("businesscardModule", ['ui.router'])
    .config(function ($stateProvider, $urlRouterProvider, $locationProvider) {

        $stateProvider
        .state('#/', {
            url: '/Home',
            templateUrl: '/templates/home.html',
        })
        .state('Cards', {
            url: '/Home/Cards',
            templateUrl: '/templates/cards.html',
            controller: 'CardsController'
        })
        .state('addCard', {
            url: '/Home/addCard',
            templateUrl: '/templates/addCard.html',
            controller: 'addCardsController'
        })
        .state('searchCard', {
            url: '/Home/Search',
            templateUrl: '/templates/search.html',
            controller: 'SearchCardController'
        })
        .state('deleteCard', {
            url: '/Home/deleteCard/:Id',
            templateUrl: '/templates/deleteCard.html',
            controller: 'deleteCardController',
            resolve: {
                item: function (CardIDService, $stateParams) {
                    var Id = $stateParams.Id;
                    return CardIDService.getItem({ Id: Id })
                }
            }
        })
        .state('editCard', {
            url: '/Home/editCard/:Id',
            templateUrl: '/templates/editCard.html',
            controller: 'editCardController',
            resolve: {
                item: function (CardIDService, $stateParams) {
                    var Id = $stateParams.Id;
                    return CardIDService.getItem({ Id: Id })
                }
            }
        })
        .state('editCard.Info', {
            url: '/Info',
            templateUrl: '/templates/cardInfo.html',
            controller: 'editCardController'
        })
        .state('editCard.Notes', {
            url: '/Notes',
            templateUrl: '/templates/cardsNote.html',
            controller: 'editCardController'
        });

        if (window.history && window.history.pushState) {
            $locationProvider.html5Mode({
                enabled: true,
                requireBase: false
            });
        }
    });