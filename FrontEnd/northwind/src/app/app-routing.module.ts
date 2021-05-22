import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {CategoryComponent} from './components/category/category.component';
import {ProductAddComponent} from './components/product-add/product-add.component';
import {ProductComponent} from './components/product/product.component';
import {UserRegistrationComponent} from './components/user-registration/user-registration.component';

const routes: Routes = [
  {path: '', pathMatch: 'full', component: ProductComponent},
  {path: 'products', component: ProductComponent},
  {path: 'products/category/:categoryId', component: ProductComponent},
  {path: 'products/add', component: ProductAddComponent},
  {path: 'auth/register', component: UserRegistrationComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
