import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalzonesComponent } from './calzones.component';

describe('CalzonesComponent', () => {
  let component: CalzonesComponent;
  let fixture: ComponentFixture<CalzonesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CalzonesComponent]
    });
    fixture = TestBed.createComponent(CalzonesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
