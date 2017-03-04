(function () {
    var $sidebarwrapper = $("#sidebar, #wrapper");
    $("#sidebarToggle").on('click', function () {
        $sidebarwrapper.toggleClass('hide-sidebar');
    });
    //var ee = $('#username');
    //ee.text("test2");
    //var main = $('#main');
    //main.on('mouseenter', function () {
    //    main.style = " background-color:#888;";
    //});
    //main.on('mouseleave', function () {
    //    main.style = "";
    //});
    //var memuItem = $("ul.menu li a");
    //memuItem.on("click", function() {
    //    alert($(this).text());
    //})
})();