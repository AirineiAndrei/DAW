import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// Components
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { RecipesComponent } from './recipes/recipes.component';

// Modules
import { MatListModule } from '@angular/material/list';
import { AdminRoutingModule } from './admin-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule, MatCardModule, MatFormFieldModule, MatIconModule, MatInputModule } from '@angular/material';


@NgModule({
  declarations: [AdminDashboardComponent, RecipesComponent, ],
  imports: [
    CommonModule,
    MatListModule,
    AdminRoutingModule,
    ReactiveFormsModule,
    MatCardModule,
    MatFormFieldModule,
    MatIconModule,
    MatButtonModule,
    FormsModule,
    MatInputModule
  ]
})
export class AdminModule { }
