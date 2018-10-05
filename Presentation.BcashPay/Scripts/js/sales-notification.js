/**
 *   File Name: sales-notification.js
 *   Description: Sales Notifications list JS.
 *   -------------------------------------------------------------------------------------------
 *   Item Name: Crypto ICO - Cryptocurrency Website Landing Page HTML + Dashboard Template
 *   Version: 1.0  
 *   Author: Pixinvent
 *   Author URL: http://www.themeforest.net/user/pixinvent
 **/

//var notifyData = [];
//var i = 0;
//setInterval(function () {

//    NotifyFunction()
//}, 15000);
//function NotifyFunction() {
//    if (notifyData.length == 0) return;
//    var data = notifyData[i++];
//    if (i == notifyData.length) i = 0;
//    $.notify({
//        icon: '/Content/flags/4x3/' + data.VariableName + '.svg',
//        title: data.VariableName,
//        message: 'Recently purchased <span class="blue">' + data.Value + ' BCASH</span>'
//    }, {
//            type: 'minimalist',
//            placement: {
//                from: "bottom",
//                align: "left"
//            },
//            animate: {
//                enter: 'animated fadeInLeftBig',
//                exit: 'animated fadeOutLeftBig'
//            },
//            icon_type: 'image',
//            template: '<div data-notify="container" class="alert alert-{0}" role="alert">' +
//                '<button type="button" aria-hidden="true" class="close" data-notify="dismiss">×</button>' +
//                '<div id="image">' +
//                '<img data-notify="icon" class="float-left">' +
//                '</div><div id="text">' +
//                '<span data-notify="title">{1}</span>' +
//                '<span data-notify="message">{2}</span>' +
//                '</div>' +
//                '</div>'
//        });
//}
//$(window).on('load', function () {
//    $.ajax({
//        type: 'POST',
//        url: '/Home/Statistics',
//        dataType: 'json',
//        success: function (data) {
//            notifyData = data;
//            NotifyFunction();
//        }
//    })
   
//});