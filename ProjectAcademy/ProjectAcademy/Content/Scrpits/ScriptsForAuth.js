let btn_auth = document.getElementById('auth_btn_one');
btn_auth.onclick = function () {
    let phone = document.getElementById('phone');
    let pass = document.getElementById('inputPassword');
    if (phone.nodeValue || pass.nodeValue == null) {
        const header_for_errmsg = document.getElementById('msg_error');
        header_for_errmsg.setAttribute('style', 'display:inline');
        
    }
};