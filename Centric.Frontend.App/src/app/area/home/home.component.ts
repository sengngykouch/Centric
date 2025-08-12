import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

import { MatButtonModule } from '@angular/material/button';

import { Category } from '../../api/models/Category.model';
import { CategoryRequest } from '../../api/models/CategoryRequest.model';

@Component({
    selector: 'app-home',
    imports: [MatButtonModule, CommonModule],
    templateUrl: './home.component.html',
    styleUrl: './home.component.scss'
})
export class HomeComponent {

    private _categories: Category[] = [];

    protected get categories() {
        return this._categories;
    }

    protected async onGetCategories(): Promise<void> {

        const baseUrl = 'http://localhost:5020/api/';

        const response = await fetch(baseUrl + 'category', { method: 'GET' });

        if (!response.ok)
            throw new Error('Failed to fetch');

        this._categories = await response.json();
    }

    protected async onAddCategory(): Promise<void> {

        const baseUrl = 'http://localhost:5020/api/';

        const newCategory: CategoryRequest = {
            name: 'Test',
            isActive: true,
            userId: 1
        };

        const request: RequestInit = {
            method: 'POST',
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify(newCategory)
        };

        const response = await fetch(baseUrl + 'category', request);

        if (!response.ok)
            throw new Error('Failed to fetch');

        console.log(await response.json());
    }
}
