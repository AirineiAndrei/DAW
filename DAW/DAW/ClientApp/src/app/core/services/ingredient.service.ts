import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Ingredient } from '../../data/interfaces/ingredient';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class IngredientService {
  private readonly route = 'ingredient';

  constructor(private readonly apiService: ApiService) { }

  getAllIngredients(): Observable<Array<Ingredient>> {
    return this.apiService.get(this.route);
  }

  addNewIngredient(newingredient: any): Observable<any> {
    console.log(newingredient);
    var ans = this.apiService.post(this.route, newingredient);
    console.log(ans);
    return ans;
  }

  deleteIngredient(ingredientId: string): Observable<any> {
    return this.apiService.delete(`${this.route}/${ingredientId}`);
  }
}
