import { NgModule} from '@angular/core';
import { Routes, RouterModule  } from '@angular/router';
import { CustomerComponent } from "./customer/customer.component";
import { RegisterComponent } from "./register/register.component";
import { ProductComponent } from "./product/product.component";

const routes: Routes = [
  {
    path: 'register', component:RegisterComponent
  },
   {
    path: 'customer', component:CustomerComponent
  },
     {
    path: 'product', component:ProductComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
