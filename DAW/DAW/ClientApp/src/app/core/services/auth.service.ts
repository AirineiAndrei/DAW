import { Injectable } from '@angular/core';
import { map, ReplaySubject } from 'rxjs';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private readonly route = 'user';

  private isAuthenticatedSubject = new ReplaySubject<boolean>(1);
  public isAuthenticated = this.isAuthenticatedSubject.asObservable();

  constructor(private readonly apiService: ApiService) { }

  login(userCredentials: any) {
    console.log(userCredentials);
    return this.apiService.post<any>(this.route + "/auth", userCredentials).pipe(
      map((response: any) => {
        if (response) {
          localStorage.setItem('token', response.token);
        }
      })
    );
  }

  register(registerInfo: any) {
    return this.apiService.post<any>(this.route + '/create-admin', registerInfo);
  }

  isLoggedIn() {
    const token = localStorage.getItem('token');
    return token != null;
  }

  logout() {
    localStorage.removeItem('token');
  }
}
