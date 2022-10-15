import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FooterComponent } from './commons/components/container/components/footer/footer.component';
import { HeaderComponent } from './commons/components/container/components/header/header.component';
import { ContainerComponent } from './commons/components/container/container.component';
import { ContainerModule } from './commons/components/container/container.module';

@NgModule({
	declarations: [AppComponent],
	imports: [BrowserModule, BrowserAnimationsModule, ContainerModule],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule { }
