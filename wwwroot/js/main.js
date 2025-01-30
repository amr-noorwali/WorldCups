var get_id;
function showmassage(id) {
    get_id = id;
  
    $('#del').modal('show');
}

function confirm_delete() {

    window.location.href = "Deletestudium1?id=" + get_id //connect to back_end

}