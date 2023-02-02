import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiUrl = "";

  constructor(private readonly httpClient: HttpClient) {
    var baseUrl = "https://localhost:7139/"; // TO DO ask how this should automatically work
    this.apiUrl = baseUrl + "api/";
  }

  get<T>(path: string, params = {}): Observable<any> {
    return this.httpClient.get<T>(`${this.apiUrl}${path}`, { params });
  }

  put<T>(path: string, body = {}): Observable<any> {
    return this.httpClient.put<T>(`${this.apiUrl}${path}`, body);
  }

  post<T>(path: string, body = {}): Observable<any> {
    return this.httpClient.post<T>(`${this.apiUrl}${path}`, body);
  }

  delete<T>(path: string): Observable<any> {
    return this.httpClient.delete<T>(`${this.apiUrl}${path}`);
  }
}
