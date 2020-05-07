import { __decorate } from "tslib";
import { Component } from '@angular/core';
let ProductComponent = class ProductComponent {
    constructor(formBuilder, router) {
        this.formBuilder = formBuilder;
        this.router = router;
    }
    ngOnInit() {
        this.productFormGroup = this.formBuilder.group({
            productName: '',
            productBrand: '',
            productPrice: '',
            productStatus: ''
        });
    }
    add() {
        this.router.navigateByUrl("");
    }
};
ProductComponent = __decorate([
    Component({
        selector: 'app-product',
        templateUrl: './product.component.html',
        styleUrls: ['./product.component.css']
    })
], ProductComponent);
export { ProductComponent };
//# sourceMappingURL=product.component.js.map