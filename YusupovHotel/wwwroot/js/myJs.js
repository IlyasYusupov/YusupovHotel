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

function CloseModal() {
    var modal = document.getElementById('modalRegisterForm');
    var modalInstance = bootstrap.Modal.getInstance(modal);
    modalInstance.hide();
}



