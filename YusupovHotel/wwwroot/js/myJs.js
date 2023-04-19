function ChangePanelsState() {
    
    if (window.location.pathname == '/' || window.location.pathname == '/registration') {
        document.getElementById('logo').style.display = 'none';
        document.getElementById('header').style.display = 'none';
        document.getElementById('nav-bar-id').style.display = 'none';
    }
    else {
        document.getElementById('logo').style.display = 'block';
        document.getElementById('header').style.display = '';
        document.getElementById('nav-bar-id').style.display = 'block';
    }
}
//lightbox.option({
//    resizeDuration: 100,
//    wrapAround: true,
//    disableScrolling: true,
//});
function date() {
    document.getElementById('from').datepicker({
                defaultDate: "+1w",
                changeMonth: true,
                numberOfMonths: 3
            })
            .on("change", function () {
                to.datepicker("option", "minDate", getDate(this));
            }),
        to = $("#to").datepicker({
            defaultDate: "+1w",
            changeMonth: true,
            numberOfMonths: 3
        })
            .on("change", function () {
                from.datepicker("option", "maxDate", getDate(this));
            });
}
function getDate(element) {
    var dateFormat = "mm/dd/yy";
    var date;
    date = datepicker.parseDate(dateFormat, element.value);
    return date;
}

//function date() {
//        from = $("#from")
//            .datepicker({
//                defaultDate: "+1w",
//                changeMonth: true,
//                numberOfMonths: 3
//            })
//            .on("change", function () {
//                to.datepicker("option", "minDate", getDate(this));
//            }),
//        to = $("#to").datepicker({
//            defaultDate: "+1w",
//            changeMonth: true,
//            numberOfMonths: 3
//        })
//            .on("change", function () {
//                from.datepicker("option", "maxDate", getDate(this));
//            });
//}

//function getDate(element) {
//    var dateFormat = "mm/dd/yy",
//    var date;
//    try {
//        date = $.datepicker.parseDate(dateFormat, element.value);
//    } catch (error) {
//        date = null;
//    }

//    return date;
//}




