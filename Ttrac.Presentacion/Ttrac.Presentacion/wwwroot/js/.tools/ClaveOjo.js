function togglePasswordVisibility() {
    var passwordInput = document.getElementById("exampleInputPassword");
    var passwordVisibilityIcon = document.getElementById("passwordVisibilityIcon");

    if (passwordInput.type === "password") {
        passwordInput.type = "text";
        passwordVisibilityIcon.classList.remove("fa-eye");
        passwordVisibilityIcon.classList.add("fa-eye-slash");
    } else {
        passwordInput.type = "password";
        passwordVisibilityIcon.classList.remove("fa-eye-slash");
        passwordVisibilityIcon.classList.add("fa-eye");
    }
}