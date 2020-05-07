import { __decorate } from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CustomerComponent } from "./customer/customer.component";
import { RegisterComponent } from "./register/register.component";
import { ProductComponent } from "./product/product.component";
const routes = [
    {
        path: 'register', component: RegisterComponent
    },
    {
        path: 'customer', component: CustomerComponent
    },
    {
        path: 'product', component: ProductComponent
    }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = __decorate([
    NgModule({
        imports: [RouterModule.forRoot(routes)],
        exports: [RouterModule]
    })
], AppRoutingModule);
export { AppRoutingModule };
//# sourceMappingURL=app-routing.module.js.map