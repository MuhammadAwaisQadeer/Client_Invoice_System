﻿window.downloadFileFromStream = async (fileName, contentStreamReference, contentType) => {
    const arrayBuffer = await contentStreamReference.arrayBuffer();
    const blob = new Blob([arrayBuffer], { type: contentType });

    const url = URL.createObjectURL(blob);
    const a = document.createElement("a");
    a.href = url;
    a.download = fileName;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    URL.revokeObjectURL(url);
};

window.ShowDeleteModal = () => {
    var modalEl = document.getElementById('deleteModal');
    if (modalEl) {
        var modal = new bootstrap.Modal(modalEl);
        modal.show();
    } else {
        console.error("Modal element not found!");
    }
};

window.HideDeleteModal = () => {
    var modalEl = document.getElementById('deleteModal');
    var modalInstance = bootstrap.Modal.getInstance(modalEl);
    if (modalInstance) {
        modalInstance.hide();
    } else {
        console.error("Modal instance not found!");
    }
};

