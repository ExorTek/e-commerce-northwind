import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {ProductAddComponent} from './components/product-add/product-add.component';
import {ProductComponent} from './components/product/product.component';
import {UserRegistrationComponent} from './components/auth/user-registration/user-registration.component';
import {UserLoginComponent} from './components/auth/user-login/user-login.component';
import {AuthComponent} from './components/auth/auth.component';

const routes: Routes = [

  {path: '', pathMatch: 'full', component: ProductComponent,},
  {path: 'products', component: ProductComponent},
  {path: 'products/category/:categoryId', component: ProductComponent},
  {path: 'products/add', component: ProductAddComponent},
  {path: 'auth', component: AuthComponent, children: [
      {path: 'login', component: UserLoginComponent},
      {path: 'register', component: UserRegistrationComponent}
    ]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
