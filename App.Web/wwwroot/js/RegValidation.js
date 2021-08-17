$(document).ready(function () {
    $("#registerForm").validate({
        rules: {
            name: {
                required: true,
                minlength: 4,
            },
            email: {
                required: true,
                email: true
            },
            pnumber: {
                required: true,
                minlength: 8
            },
            password: {
                required: true,
                minlength: 8
            },
            Cpassword: {
                required: true,
                equalTo: '#password',
                minlength: 8
            }
        },
        messages: {
            name: {
                required: 'Enter username',
                minlength: 'At least 4 symbols'
            },
            email: {
                required: 'Enter email',
                email: 'Wrong email format'
            },
            pnumber: {
                required: 'Enter phone number',
                minlength: 'At least 8 digits'
            },
            password: {
                required: 'Enter password',
                minlength: 'At least 8 symbols'
            },
            Cpassword: {
                required: 'Confirm your password',
                equalTo: 'Passwords didn`t match'
            }

        }
    })
})