import { __decorate } from "tslib";
import { Component } from '@angular/core';
let RegisterComponent = class RegisterComponent {
    constructor(formBuilder, router, http) {
        this.formBuilder = formBuilder;
        this.router = router;
        this.http = http;
    }
    ngOnInit() {
        this.registerFormGroup = this.formBuilder.group({
            firstName: '',
            lastName: '',
            email: '',
            password: '',
            confirmPassword: '',
            mobileNumber: '',
            gender: '',
            address: '',
            dob: '',
        });
    }
    register() {
        //var mobileNumber=parseInt(this.registerFormGroup.controls.mobileNumber.value);
        this.http.post('https://localhost:44304/api/customer', {
            FirstName: this.registerFormGroup.controls.firstName.value,
            LastName: this.registerFormGroup.controls.lastName.value,
            Email: this.registerFormGroup.controls.email.value,
            Password: this.registerFormGroup.controls.password.value,
            ConfirmPassword: this.registerFormGroup.controls.confirmPassword.value,
            MobileNumber: this.registerFormGroup.controls.mobileNumber.value,
            Gender: this.registerFormGroup.controls.gender.value,
            Address: this.registerFormGroup.controls.address.value,
            Dob: this.registerFormGroup.controls.dob.value,
        }).subscribe(res => {
            console.log(res);
        });
        this.router.navigateByUrl("customer");
    }
};
RegisterComponent = __decorate([
    Component({
        selector: 'app-register',
        templateUrl: './register.component.html',
        styleUrls: ['./register.component.css']
    })
], RegisterComponent);
export { RegisterComponent };
//# sourceMappingURL=register.component.js.map