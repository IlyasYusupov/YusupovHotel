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
lightbox.option({
    resizeDuration: 100,
    wrapAround: true,
    disableScrolling: true,
});

// Add the following code if you want the name of the file appear on select
    $(".custom-file-input").on("change", function() {
  var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});
