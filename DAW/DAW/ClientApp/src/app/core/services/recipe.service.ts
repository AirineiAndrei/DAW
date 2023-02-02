import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Recipe } from '../../data/interfaces/recipe';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class RecipeService {
  private readonly route = 'recipe';

  constructor(private readonly apiService: ApiService) { }

  getAllRecipes(): Observable<Array<Recipe>> {
    return this.apiService.get(this.route);
  }

  addNewRecipe(newrecipe: any): Observable<any> {
    return this.apiService.post(this.route, newrecipe);
  }

  addStudentsToRecipe(recipeId: string, studentsIds: Array<string>): Observable<any> {
    return this.apiService.post(`${this.route}/${recipeId}`, studentsIds);
  }

  deleteRecipe(recipeId: string): Observable<any> {
    return this.apiService.delete(`${this.route}/${recipeId}`);
  }
}
