import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { RecipesComponent } from './recipes/recipes.component';

const routes: Routes = [
  {
    path: "dashboard",
    component: AdminDashboardComponent,
    children: [
      {
        path: "recipes",
        component: RecipesComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
