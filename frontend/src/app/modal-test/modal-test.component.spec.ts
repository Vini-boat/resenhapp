import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalTestComponent } from './modal-test.component';

describe('ModalTestComponent', () => {
  let component: ModalTestComponent;
  let fixture: ComponentFixture<ModalTestComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ModalTestComponent]
    });
    fixture = TestBed.createComponent(ModalTestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
