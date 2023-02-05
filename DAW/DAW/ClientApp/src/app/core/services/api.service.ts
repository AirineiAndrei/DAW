import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tokenGetter } from 'src/app/app.module';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiUrl = "";

  private jwt()
  {
    var jwtToken = tokenGetter() || "NO TOKEN";
    console.log("Token is " + jwtToken);
    return new HttpHeaders().set('Authorization',jwtToken );
  }

  constructor(private readonly httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiUrl = baseUrl + "api/";
  }

  get<T>(path: string, params = {}): Observable<any> {
    return this.httpClient.get<T>(`${this.apiUrl}${path}`, { params ,'headers': this.jwt()});
  }

  put<T>(path: string, body = {}): Observable<any> {
    return this.httpClient.put<T>(`${this.apiUrl}${path}`, body, {'headers': this.jwt()});
  }

  post<T>(path: string, body = {}): Observable<any> {
    console.log(`${this.apiUrl}${path}`);
    console.log(body);
    return this.httpClient.post<T>(`${this.apiUrl}${path}`, body, {'headers': this.jwt()});
  }

  delete<T>(path: string): Observable<any> {
    return this.httpClient.delete<T>(`${this.apiUrl}${path}`,{'headers': this.jwt()});
  }
}
