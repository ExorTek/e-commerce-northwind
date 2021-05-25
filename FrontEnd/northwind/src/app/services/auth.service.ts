import {Injectable} from '@angular/core';
import {environment} from '../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {SingleResponseModel} from '../models/singleResponseModel';
import {TokenModel} from '../models/tokenModel';
import {LoginModel} from '../models/loginModel';
import {Observable} from 'rxjs';
import {RegisterModel} from '../models/registerModel';
@Injectable({
  providedIn: 'root'
})
export class AuthService {

  apiUrl = environment.apiUrl + 'auth/';
  constructor(private httpClient: HttpClient) {
  }

  login(loginModel: LoginModel): Observable<SingleResponseModel<TokenModel>> {
    return this.httpClient.post<SingleResponseModel<TokenModel>>(this.apiUrl + 'login', loginModel);
  }

  register(registerModel: RegisterModel): Observable<SingleResponseModel<TokenModel>> {
    return this.httpClient.post<SingleResponseModel<TokenModel>>(this.apiUrl + 'register', registerModel);
  }

  isAuthenticated() {
    return !!localStorage.getItem('token');
  }
}
