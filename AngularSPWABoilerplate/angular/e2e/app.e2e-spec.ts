import { PruebaTemplatePage } from './app.po';

describe('Prueba App', function() {
  let page: PruebaTemplatePage;

  beforeEach(() => {
    page = new PruebaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
