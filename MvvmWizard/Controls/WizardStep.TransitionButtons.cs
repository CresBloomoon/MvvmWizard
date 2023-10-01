namespace MvvmWizard.Controls {
    using System.Windows;
    using System.Windows.Media;

    public partial class WizardStep {
        public static readonly DependencyProperty BackButtonTooltipProperty = DependencyProperty.Register(nameof(BackButtonTooltip), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonTooltipProperty = DependencyProperty.Register(nameof(SkipButtonTooltip), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonTooltipProperty = DependencyProperty.Register(nameof(ForwardButtonTooltip), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonTooltipProperty = DependencyProperty.Register(nameof(CancelButtonTooltip), typeof(object), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonVisibilityProperty = DependencyProperty.Register(nameof(BackButtonVisibility), typeof(Visibility), typeof(WizardStep), new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty SkipButtonVisibilityProperty = DependencyProperty.Register(nameof(SkipButtonVisibility), typeof(Visibility), typeof(WizardStep), new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty ForwardButtonVisibilityProperty = DependencyProperty.Register(nameof(ForwardButtonVisibility), typeof(Visibility), typeof(WizardStep), new PropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty CancelButtonVisibilityProperty = DependencyProperty.Register(nameof(CancelButtonVisibility), typeof(Visibility), typeof(WizardStep), new PropertyMetadata(Visibility.Visible));

        public static readonly DependencyProperty BackButtonIsEnabledProperty = DependencyProperty.Register(nameof(BackButtonIsEnabled), typeof(bool), typeof(WizardStep), new PropertyMetadata(true));
        public static readonly DependencyProperty SkipButtonIsEnabledProperty = DependencyProperty.Register(nameof(SkipButtonIsEnabled), typeof(bool), typeof(WizardStep), new PropertyMetadata(true));
        public static readonly DependencyProperty ForwardButtonIsEnabledProperty = DependencyProperty.Register(nameof(ForwardButtonIsEnabled), typeof(bool), typeof(WizardStep), new PropertyMetadata(true));
        public static readonly DependencyProperty CancelButtonIsEnabledProperty = DependencyProperty.Register(nameof(CancelButtonIsEnabled), typeof(bool), typeof(WizardStep), new PropertyMetadata(true));

        public static readonly DependencyProperty BackButtonTitleProperty = DependencyProperty.Register(nameof(BackButtonTitle), typeof(string), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonTitleProperty = DependencyProperty.Register(nameof(SkipButtonTitle), typeof(string), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonTitleProperty = DependencyProperty.Register(nameof(ForwardButtonTitle), typeof(string), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonTitleProperty = DependencyProperty.Register(nameof(CancelButtonTitle), typeof(string), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonIconProperty = DependencyProperty.Register(nameof(BackButtonIcon), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonIconProperty = DependencyProperty.Register(nameof(SkipButtonIcon), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonIconProperty = DependencyProperty.Register(nameof(ForwardButtonIcon), typeof(object), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonIconProperty = DependencyProperty.Register(nameof(CancelButtonIcon), typeof(object), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonForegroundProperty = DependencyProperty.Register(nameof(BackButtonForeground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty SkipButtonForegroundProperty = DependencyProperty.Register(nameof(SkipButtonForeground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty ForwardButtonForegroundProperty = DependencyProperty.Register(nameof(ForwardButtonForeground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty CancelButtonForegroundProperty = DependencyProperty.Register(nameof(CancelButtonForeground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Black));

        public static readonly DependencyProperty BackButtonBackgroundProperty = DependencyProperty.Register(nameof(BackButtonBackground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Transparent));
        public static readonly DependencyProperty SkipButtonBackgroundProperty = DependencyProperty.Register(nameof(SkipButtonBackground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Transparent));
        public static readonly DependencyProperty ForwardButtonBackgroundProperty = DependencyProperty.Register(nameof(ForwardButtonBackground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Transparent));
        public static readonly DependencyProperty CancelButtonBackgroundProperty = DependencyProperty.Register(nameof(CancelButtonBackground), typeof(Brush), typeof(WizardStep), new PropertyMetadata(Brushes.Transparent));

        public static readonly DependencyProperty BackButtonMouseMouseOverBackgroundProperty = DependencyProperty.Register(nameof(BackButtonMouseMouseOverBackground), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonMouseMouseOverBackgroundProperty = DependencyProperty.Register(nameof(SkipButtonMouseMouseOverBackground), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonMouseMouseOverBackgroundProperty = DependencyProperty.Register(nameof(ForwardButtonMouseMouseOverBackground), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonMouseMouseOverBackgroundProperty = DependencyProperty.Register(nameof(CancelButtonMouseMouseOverBackground), typeof(Brush), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonBorderBrushProperty = DependencyProperty.Register(nameof(BackButtonBorderBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonBorderBrushProperty = DependencyProperty.Register(nameof(SkipButtonBorderBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonBorderBrushProperty = DependencyProperty.Register(nameof(ForwardButtonBorderBrush), typeof(Brush), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonBorderBrushProperty = DependencyProperty.Register(nameof(CancelButtonBorderBrush), typeof(Brush), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonBorderThicknessProperty = DependencyProperty.Register(nameof(BackButtonBorderThickness), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonBorderThicknessProperty = DependencyProperty.Register(nameof(SkipButtonBorderThickness), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonBorderThicknessProperty = DependencyProperty.Register(nameof(ForwardButtonBorderThickness), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonBorderThicknessProperty = DependencyProperty.Register(nameof(CancelButtonBorderThickness), typeof(Thickness), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonMinWidthProperty = DependencyProperty.Register(nameof(BackButtonMinWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty SkipButtonMinWidthProperty = DependencyProperty.Register(nameof(SkipButtonMinWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty ForwardButtonMinWidthProperty = DependencyProperty.Register(nameof(ForwardButtonMinWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty CancelButtonMinWidthProperty = DependencyProperty.Register(nameof(CancelButtonMinWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));

        public static readonly DependencyProperty BackButtonMinHeightProperty = DependencyProperty.Register(nameof(BackButtonMinHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty SkipButtonMinHeightProperty = DependencyProperty.Register(nameof(SkipButtonMinHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty ForwardButtonMinHeightProperty = DependencyProperty.Register(nameof(ForwardButtonMinHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));
        public static readonly DependencyProperty CancelButtonMinHeightProperty = DependencyProperty.Register(nameof(CancelButtonMinHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(0.0));

        public static readonly DependencyProperty BackButtonWidthProperty = DependencyProperty.Register(nameof(BackButtonWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty SkipButtonWidthProperty = DependencyProperty.Register(nameof(SkipButtonWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty ForwardButtonWidthProperty = DependencyProperty.Register(nameof(ForwardButtonWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty CancelButtonWidthProperty = DependencyProperty.Register(nameof(CancelButtonWidth), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));

        public static readonly DependencyProperty BackButtonHeightProperty = DependencyProperty.Register(nameof(BackButtonHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty SkipButtonHeightProperty = DependencyProperty.Register(nameof(SkipButtonHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty ForwardButtonHeightProperty = DependencyProperty.Register(nameof(ForwardButtonHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));
        public static readonly DependencyProperty CancelButtonHeightProperty = DependencyProperty.Register(nameof(CancelButtonHeight), typeof(double), typeof(WizardStep), new FrameworkPropertyMetadata(double.NaN));

        public static readonly DependencyProperty BackButtonMaxWidthProperty = DependencyProperty.Register(nameof(BackButtonMaxWidth), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty SkipButtonMaxWidthProperty = DependencyProperty.Register(nameof(SkipButtonMaxWidth), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty ForwardButtonMaxWidthProperty = DependencyProperty.Register(nameof(ForwardButtonMaxWidth), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty CancelButtonMaxWidthProperty = DependencyProperty.Register(nameof(CancelButtonMaxWidth), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));

        public static readonly DependencyProperty BackButtonMaxHeightProperty = DependencyProperty.Register(nameof(BackButtonMaxHeight), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty SkipButtonMaxHeightProperty = DependencyProperty.Register(nameof(SkipButtonMaxHeight), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty ForwardButtonMaxHeightProperty = DependencyProperty.Register(nameof(ForwardButtonMaxHeight), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));
        public static readonly DependencyProperty CancelButtonMaxHeightProperty = DependencyProperty.Register(nameof(CancelButtonMaxHeight), typeof(double), typeof(WizardStep), new PropertyMetadata(double.PositiveInfinity));

        public static readonly DependencyProperty BackButtonMarginProperty = DependencyProperty.Register(nameof(BackButtonMargin), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonMarginProperty = DependencyProperty.Register(nameof(SkipButtonMargin), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonMarginProperty = DependencyProperty.Register(nameof(ForwardButtonMargin), typeof(Thickness), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonMarginProperty = DependencyProperty.Register(nameof(CancelButtonMargin), typeof(Thickness), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonCornerRadiusProperty = DependencyProperty.Register(nameof(BackButtonCornerRadius), typeof(CornerRadius), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonCornerRadiusProperty = DependencyProperty.Register(nameof(SkipButtonCornerRadius), typeof(CornerRadius), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonCornerRadiusProperty = DependencyProperty.Register(nameof(ForwardButtonCornerRadius), typeof(CornerRadius), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonCornerRadiusProperty = DependencyProperty.Register(nameof(CancelButtonCornerRadius), typeof(CornerRadius), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonHorizontalContentAlignmentProperty = DependencyProperty.Register(nameof(BackButtonHorizontalContentAlignment), typeof(HorizontalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonHorizontalContentAlignmentProperty = DependencyProperty.Register(nameof(SkipButtonHorizontalContentAlignment), typeof(HorizontalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonHorizontalContentAlignmentProperty = DependencyProperty.Register(nameof(ForwardButtonHorizontalContentAlignment), typeof(HorizontalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonHorizontalContentAlignmentProperty = DependencyProperty.Register(nameof(CancelButtonHorizontalContentAlignment), typeof(HorizontalAlignment), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonVerticalContentAlignmentProperty = DependencyProperty.Register(nameof(BackButtonVerticalContentAlignment), typeof(VerticalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonVerticalContentAlignmentProperty = DependencyProperty.Register(nameof(SkipButtonVerticalContentAlignment), typeof(VerticalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonVerticalContentAlignmentProperty = DependencyProperty.Register(nameof(ForwardButtonVerticalContentAlignment), typeof(VerticalAlignment), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonVerticalContentAlignmentProperty = DependencyProperty.Register(nameof(CancelButtonVerticalContentAlignment), typeof(VerticalAlignment), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonFontSizeProperty = DependencyProperty.Register(nameof(BackButtonFontSize), typeof(double), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonFontSizeProperty = DependencyProperty.Register(nameof(SkipButtonFontSize), typeof(double), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonFontSizeProperty = DependencyProperty.Register(nameof(ForwardButtonFontSize), typeof(double), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonFontSizeProperty = DependencyProperty.Register(nameof(CancelButtonFontSize), typeof(double), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonFontWeightProperty = DependencyProperty.Register(nameof(BackButtonFontWeight), typeof(FontWeight), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonFontWeightProperty = DependencyProperty.Register(nameof(SkipButtonFontWeight), typeof(FontWeight), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonFontWeightProperty = DependencyProperty.Register(nameof(ForwardButtonFontWeight), typeof(FontWeight), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonFontWeightProperty = DependencyProperty.Register(nameof(CancelButtonFontWeight), typeof(FontWeight), typeof(WizardStep));

        public static readonly DependencyProperty BackButtonFontStyleProperty = DependencyProperty.Register(nameof(BackButtonFontStyle), typeof(FontStyle), typeof(WizardStep));
        public static readonly DependencyProperty SkipButtonFontStyleProperty = DependencyProperty.Register(nameof(SkipButtonFontStyle), typeof(FontStyle), typeof(WizardStep));
        public static readonly DependencyProperty ForwardButtonFontStyleProperty = DependencyProperty.Register(nameof(ForwardButtonFontStyle), typeof(FontStyle), typeof(WizardStep));
        public static readonly DependencyProperty CancelButtonFontStyleProperty = DependencyProperty.Register(nameof(CancelButtonFontStyle), typeof(FontStyle), typeof(WizardStep));

        /* Tooltip */
        public object BackButtonTooltip {
            get { return this.GetValue(BackButtonTooltipProperty); }
            set { this.SetValue(BackButtonTooltipProperty, value); }
        }

        public object SkipButtonTooltip {
            get { return this.GetValue(SkipButtonTooltipProperty); }
            set { this.SetValue(SkipButtonTooltipProperty, value); }
        }

        public object ForwardButtonTooltip {
            get { return this.GetValue(ForwardButtonTooltipProperty); }
            set { this.SetValue(ForwardButtonTooltipProperty, value); }
        }

        public object CancelButtonTooltip {
            get { return this.GetValue(CancelButtonTooltipProperty); }
            set { this.SetValue(CancelButtonTooltipProperty, value); }
        }

        /* Visibility */
        public Visibility BackButtonVisibility {
            get { return (Visibility)this.GetValue(BackButtonVisibilityProperty); }
            set { this.SetValue(BackButtonVisibilityProperty, value); }
        }

        public Visibility SkipButtonVisibility {
            get { return (Visibility)this.GetValue(SkipButtonVisibilityProperty); }
            set { this.SetValue(SkipButtonVisibilityProperty, value); }
        }

        public Visibility ForwardButtonVisibility {
            get { return (Visibility)this.GetValue(ForwardButtonVisibilityProperty); }
            set { this.SetValue(ForwardButtonVisibilityProperty, value); }
        }

        public Visibility CancelButtonVisibility {
            get { return (Visibility)this.GetValue(CancelButtonVisibilityProperty); }
            set { this.SetValue(CancelButtonVisibilityProperty, value); }
        }

        /* IsEnabled */
        public bool BackButtonIsEnabled {
            get { return (bool)this.GetValue(BackButtonIsEnabledProperty); }
            set { this.SetValue(BackButtonIsEnabledProperty, value); }
        }

        public bool SkipButtonIsEnabled {
            get { return (bool)this.GetValue(SkipButtonIsEnabledProperty); }
            set { this.SetValue(SkipButtonIsEnabledProperty, value); }
        }

        public bool ForwardButtonIsEnabled {
            get { return (bool)this.GetValue(ForwardButtonIsEnabledProperty); }
            set { this.SetValue(ForwardButtonIsEnabledProperty, value); }
        }

        public bool CancelButtonIsEnabled {
            get { return (bool)this.GetValue(CancelButtonIsEnabledProperty); }
            set { this.SetValue(CancelButtonIsEnabledProperty, value); }
        }

        /* Title */
        public string BackButtonTitle {
            get { return (string)this.GetValue(BackButtonTitleProperty); }
            set { this.SetValue(BackButtonTitleProperty, value); }
        }

        public string SkipButtonTitle {
            get { return (string)this.GetValue(SkipButtonTitleProperty); }
            set { this.SetValue(SkipButtonTitleProperty, value); }
        }

        public string ForwardButtonTitle {
            get { return (string)this.GetValue(ForwardButtonTitleProperty); }
            set { this.SetValue(ForwardButtonTitleProperty, value); }
        }

        public string CancelButtonTitle {
            get { return (string)this.GetValue(CancelButtonTitleProperty); }
            set { this.SetValue(CancelButtonTitleProperty, value); }
        }

        /* Icon */
        public object BackButtonIcon {
            get { return this.GetValue(BackButtonIconProperty); }
            set { this.SetValue(BackButtonIconProperty, value); }
        }

        public object SkipButtonIcon {
            get { return this.GetValue(SkipButtonIconProperty); }
            set { this.SetValue(SkipButtonIconProperty, value); }
        }

        public object ForwardButtonIcon {
            get { return this.GetValue(ForwardButtonIconProperty); }
            set { this.SetValue(ForwardButtonIconProperty, value); }
        }

        public object CancelButtonIcon {
            get { return this.GetValue(CancelButtonIconProperty); }
            set { this.SetValue(CancelButtonIconProperty, value); }
        }

        /* Foreground */
        public Brush BackButtonForeground {
            get { return (Brush)this.GetValue(BackButtonForegroundProperty); }
            set { this.SetValue(BackButtonForegroundProperty, value); }
        }

        public Brush SkipButtonForeground {
            get { return (Brush)this.GetValue(SkipButtonForegroundProperty); }
            set { this.SetValue(SkipButtonForegroundProperty, value); }
        }

        public Brush ForwardButtonForeground {
            get { return (Brush)this.GetValue(ForwardButtonForegroundProperty); }
            set { this.SetValue(ForwardButtonForegroundProperty, value); }
        }

        public Brush CancelButtonForeground {
            get { return (Brush)this.GetValue(CancelButtonForegroundProperty); }
            set { this.SetValue(CancelButtonForegroundProperty, value); }
        }

        /* Background */
        public Brush BackButtonBackground {
            get { return (Brush)this.GetValue(BackButtonBackgroundProperty); }
            set { this.SetValue(BackButtonBackgroundProperty, value); }
        }

        public Brush SkipButtonBackground {
            get { return (Brush)this.GetValue(SkipButtonBackgroundProperty); }
            set { this.SetValue(SkipButtonBackgroundProperty, value); }
        }

        public Brush ForwardButtonBackground {
            get { return (Brush)this.GetValue(ForwardButtonBackgroundProperty); }
            set { this.SetValue(ForwardButtonBackgroundProperty, value); }
        }

        public Brush CancelButtonBackground {
            get { return (Brush)this.GetValue(CancelButtonBackgroundProperty); }
            set { this.SetValue(CancelButtonBackgroundProperty, value); }
        }

        /* Mouse Over Background */
        public Brush BackButtonMouseMouseOverBackground {
            get { return (Brush)this.GetValue(BackButtonMouseMouseOverBackgroundProperty); }
            set { this.SetValue(BackButtonMouseMouseOverBackgroundProperty, value); }
        }

        public Brush SkipButtonMouseMouseOverBackground {
            get { return (Brush)this.GetValue(SkipButtonMouseMouseOverBackgroundProperty); }
            set { this.SetValue(SkipButtonMouseMouseOverBackgroundProperty, value); }
        }

        public Brush ForwardButtonMouseMouseOverBackground {
            get { return (Brush)this.GetValue(ForwardButtonMouseMouseOverBackgroundProperty); }
            set { this.SetValue(ForwardButtonMouseMouseOverBackgroundProperty, value); }
        }

        public Brush CancelButtonMouseMouseOverBackground {
            get { return (Brush)this.GetValue(CancelButtonMouseMouseOverBackgroundProperty); }
            set { this.SetValue(CancelButtonMouseMouseOverBackgroundProperty, value); }
        }

        /* Border Brush */
        public Brush BackButtonBorderBrush {
            get { return (Brush)this.GetValue(BackButtonBorderBrushProperty); }
            set { this.SetValue(BackButtonBorderBrushProperty, value); }
        }

        public Brush SkipButtonBorderBrush {
            get { return (Brush)this.GetValue(SkipButtonBorderBrushProperty); }
            set { this.SetValue(SkipButtonBorderBrushProperty, value); }
        }

        public Brush ForwardButtonBorderBrush {
            get { return (Brush)this.GetValue(ForwardButtonBorderBrushProperty); }
            set { this.SetValue(ForwardButtonBorderBrushProperty, value); }
        }

        public Brush CancelButtonBorderBrush {
            get { return (Brush)this.GetValue(CancelButtonBorderBrushProperty); }
            set { this.SetValue(CancelButtonBorderBrushProperty, value); }
        }

        /* Border Thickness */
        public Thickness BackButtonBorderThickness {
            get { return (Thickness)this.GetValue(BackButtonBorderThicknessProperty); }
            set { this.SetValue(BackButtonBorderThicknessProperty, value); }
        }

        public Thickness SkipButtonBorderThickness {
            get { return (Thickness)this.GetValue(SkipButtonBorderThicknessProperty); }
            set { this.SetValue(SkipButtonBorderThicknessProperty, value); }
        }

        public Thickness ForwardButtonBorderThickness {
            get { return (Thickness)this.GetValue(ForwardButtonBorderThicknessProperty); }
            set { this.SetValue(ForwardButtonBorderThicknessProperty, value); }
        }

        public Thickness CancelButtonBorderThickness {
            get { return (Thickness)this.GetValue(CancelButtonBorderThicknessProperty); }
            set { this.SetValue(CancelButtonBorderThicknessProperty, value); }
        }

        /* Min Width */
        public double BackButtonMinWidth {
            get { return (double)this.GetValue(BackButtonMinWidthProperty); }
            set { this.SetValue(BackButtonMinWidthProperty, value); }
        }

        public double SkipButtonMinWidth {
            get { return (double)this.GetValue(SkipButtonMinWidthProperty); }
            set { this.SetValue(SkipButtonMinWidthProperty, value); }
        }

        public double ForwardButtonMinWidth {
            get { return (double)this.GetValue(ForwardButtonMinWidthProperty); }
            set { this.SetValue(ForwardButtonMinWidthProperty, value); }
        }

        public double CancelButtonMinWidth {
            get { return (double)this.GetValue(CancelButtonMinWidthProperty); }
            set { this.SetValue(CancelButtonMinWidthProperty, value); }
        }

        /* Min Height */
        public double BackButtonMinHeight {
            get { return (double)this.GetValue(BackButtonMinHeightProperty); }
            set { this.SetValue(BackButtonMinHeightProperty, value); }
        }

        public double SkipButtonMinHeight {
            get { return (double)this.GetValue(SkipButtonMinHeightProperty); }
            set { this.SetValue(SkipButtonMinHeightProperty, value); }
        }

        public double ForwardButtonMinHeight {
            get { return (double)this.GetValue(ForwardButtonMinHeightProperty); }
            set { this.SetValue(ForwardButtonMinHeightProperty, value); }
        }

        public double CancelButtonMinHeight {
            get { return (double)this.GetValue(CancelButtonMinHeightProperty); }
            set { this.SetValue(CancelButtonMinHeightProperty, value); }
        }

        /* Width */
        public double BackButtonWidth {
            get { return (double)this.GetValue(BackButtonWidthProperty); }
            set { this.SetValue(BackButtonWidthProperty, value); }
        }

        public double SkipButtonWidth {
            get { return (double)this.GetValue(SkipButtonWidthProperty); }
            set { this.SetValue(SkipButtonWidthProperty, value); }
        }

        public double ForwardButtonWidth {
            get { return (double)this.GetValue(ForwardButtonWidthProperty); }
            set { this.SetValue(ForwardButtonWidthProperty, value); }
        }

        public double CancelButtonWidth {
            get { return (double)this.GetValue(CancelButtonWidthProperty); }
            set { this.SetValue(CancelButtonWidthProperty, value); }
        }

        /* Height */
        public double BackButtonHeight {
            get { return (double)this.GetValue(BackButtonHeightProperty); }
            set { this.SetValue(BackButtonHeightProperty, value); }
        }

        public double SkipButtonHeight {
            get { return (double)this.GetValue(SkipButtonHeightProperty); }
            set { this.SetValue(SkipButtonHeightProperty, value); }
        }

        public double ForwardButtonHeight {
            get { return (double)this.GetValue(ForwardButtonHeightProperty); }
            set { this.SetValue(ForwardButtonHeightProperty, value); }
        }

        public double CancelButtonHeight {
            get { return (double)this.GetValue(CancelButtonHeightProperty); }
            set { this.SetValue(CancelButtonHeightProperty, value); }
        }

        /* Max Width */
        public double BackButtonMaxWidth {
            get { return (double)this.GetValue(BackButtonMaxWidthProperty); }
            set { this.SetValue(BackButtonMaxWidthProperty, value); }
        }

        public double SkipButtonMaxWidth {
            get { return (double)this.GetValue(SkipButtonMaxWidthProperty); }
            set { this.SetValue(SkipButtonMaxWidthProperty, value); }
        }

        public double ForwardButtonMaxWidth {
            get { return (double)this.GetValue(ForwardButtonMaxWidthProperty); }
            set { this.SetValue(ForwardButtonMaxWidthProperty, value); }
        }

        public double CancelButtonMaxWidth {
            get { return (double)this.GetValue(CancelButtonMaxWidthProperty); }
            set { this.SetValue(CancelButtonMaxWidthProperty, value); }
        }

        /* Max Height */
        public double BackButtonMaxHeight {
            get { return (double)this.GetValue(BackButtonMaxHeightProperty); }
            set { this.SetValue(BackButtonMaxHeightProperty, value); }
        }

        public double SkipButtonMaxHeight {
            get { return (double)this.GetValue(SkipButtonMaxHeightProperty); }
            set { this.SetValue(SkipButtonMaxHeightProperty, value); }
        }

        public double ForwardButtonMaxHeight {
            get { return (double)this.GetValue(ForwardButtonMaxHeightProperty); }
            set { this.SetValue(ForwardButtonMaxHeightProperty, value); }
        }

        public double CancelButtonMaxHeight {
            get { return (double)this.GetValue(CancelButtonMaxHeightProperty); }
            set { this.SetValue(CancelButtonMaxHeightProperty, value); }
        }

        /* Margin */
        public Thickness BackButtonMargin {
            get { return (Thickness)this.GetValue(BackButtonMarginProperty); }
            set { this.SetValue(BackButtonMarginProperty, value); }
        }

        public Thickness SkipButtonMargin {
            get { return (Thickness)this.GetValue(SkipButtonMarginProperty); }
            set { this.SetValue(SkipButtonMarginProperty, value); }
        }

        public Thickness ForwardButtonMargin {
            get { return (Thickness)this.GetValue(ForwardButtonMarginProperty); }
            set { this.SetValue(ForwardButtonMarginProperty, value); }
        }

        public Thickness CancelButtonMargin {
            get { return (Thickness)this.GetValue(CancelButtonMarginProperty); }
            set { this.SetValue(CancelButtonMarginProperty, value); }
        }

        /* Corner Radius */
        public CornerRadius BackButtonCornerRadius {
            get { return (CornerRadius)this.GetValue(BackButtonCornerRadiusProperty); }
            set { this.SetValue(BackButtonCornerRadiusProperty, value); }
        }

        public CornerRadius SkipButtonCornerRadius {
            get { return (CornerRadius)this.GetValue(SkipButtonCornerRadiusProperty); }
            set { this.SetValue(SkipButtonCornerRadiusProperty, value); }
        }

        public CornerRadius ForwardButtonCornerRadius {
            get { return (CornerRadius)this.GetValue(ForwardButtonCornerRadiusProperty); }
            set { this.SetValue(ForwardButtonCornerRadiusProperty, value); }
        }

        public CornerRadius CancelButtonCornerRadius {
            get { return (CornerRadius)this.GetValue(CancelButtonCornerRadiusProperty); }
            set { this.SetValue(CancelButtonCornerRadiusProperty, value); }
        }

        /* Horizontal Content Alignment */
        public HorizontalAlignment BackButtonHorizontalContentAlignment {
            get { return (HorizontalAlignment)this.GetValue(BackButtonHorizontalContentAlignmentProperty); }
            set { this.SetValue(BackButtonHorizontalContentAlignmentProperty, value); }
        }

        public HorizontalAlignment SkipButtonHorizontalContentAlignment {
            get { return (HorizontalAlignment)this.GetValue(SkipButtonHorizontalContentAlignmentProperty); }
            set { this.SetValue(SkipButtonHorizontalContentAlignmentProperty, value); }
        }

        public HorizontalAlignment ForwardButtonHorizontalContentAlignment {
            get { return (HorizontalAlignment)this.GetValue(ForwardButtonHorizontalContentAlignmentProperty); }
            set { this.SetValue(ForwardButtonHorizontalContentAlignmentProperty, value); }
        }

        public HorizontalAlignment CancelButtonHorizontalContentAlignment {
            get { return (HorizontalAlignment)this.GetValue(CancelButtonHorizontalContentAlignmentProperty); }
            set { this.SetValue(CancelButtonHorizontalContentAlignmentProperty, value); }
        }

        /* Vertical Content Alignment */
        public VerticalAlignment BackButtonVerticalContentAlignment {
            get { return (VerticalAlignment)this.GetValue(BackButtonVerticalContentAlignmentProperty); }
            set { this.SetValue(BackButtonVerticalContentAlignmentProperty, value); }
        }

        public VerticalAlignment SkipButtonVerticalContentAlignment {
            get { return (VerticalAlignment)this.GetValue(SkipButtonVerticalContentAlignmentProperty); }
            set { this.SetValue(SkipButtonVerticalContentAlignmentProperty, value); }
        }

        public VerticalAlignment ForwardButtonVerticalContentAlignment {
            get { return (VerticalAlignment)this.GetValue(ForwardButtonVerticalContentAlignmentProperty); }
            set { this.SetValue(ForwardButtonVerticalContentAlignmentProperty, value); }
        }

        public VerticalAlignment CancelButtonVerticalContentAlignment {
            get { return (VerticalAlignment)this.GetValue(CancelButtonVerticalContentAlignmentProperty); }
            set { this.SetValue(CancelButtonVerticalContentAlignmentProperty, value); }
        }

        /* Font Size */
        public double BackButtonFontSize {
            get { return (double)this.GetValue(BackButtonFontSizeProperty); }
            set { this.SetValue(BackButtonFontSizeProperty, value); }
        }

        public double SkipButtonFontSize {
            get { return (double)this.GetValue(SkipButtonFontSizeProperty); }
            set { this.SetValue(SkipButtonFontSizeProperty, value); }
        }

        public double ForwardButtonFontSize {
            get { return (double)this.GetValue(ForwardButtonFontSizeProperty); }
            set { this.SetValue(ForwardButtonFontSizeProperty, value); }
        }

        public double CancelButtonFontSize {
            get { return (double)this.GetValue(CancelButtonFontSizeProperty); }
            set { this.SetValue(CancelButtonFontSizeProperty, value); }
        }

        /* Font Weight */
        public FontWeight BackButtonFontWeight {
            get { return (FontWeight)this.GetValue(BackButtonFontWeightProperty); }
            set { this.SetValue(BackButtonFontWeightProperty, value); }
        }

        public FontWeight SkipButtonFontWeight {
            get { return (FontWeight)this.GetValue(SkipButtonFontWeightProperty); }
            set { this.SetValue(SkipButtonFontWeightProperty, value); }
        }

        public FontWeight ForwardButtonFontWeight {
            get { return (FontWeight)this.GetValue(ForwardButtonFontWeightProperty); }
            set { this.SetValue(ForwardButtonFontWeightProperty, value); }
        }

        public FontWeight CancelButtonFontWeight {
            get { return (FontWeight)this.GetValue(CancelButtonFontWeightProperty); }
            set { this.SetValue(CancelButtonFontWeightProperty, value); }
        }

        /* Font Style */
        public FontStyle BackButtonFontStyle {
            get { return (FontStyle)this.GetValue(BackButtonFontStyleProperty); }
            set { this.SetValue(BackButtonFontStyleProperty, value); }
        }

        public FontStyle SkipButtonFontStyle {
            get { return (FontStyle)this.GetValue(SkipButtonFontStyleProperty); }
            set { this.SetValue(SkipButtonFontStyleProperty, value); }
        }

        public FontStyle ForwardButtonFontStyle {
            get { return (FontStyle)this.GetValue(ForwardButtonFontStyleProperty); }
            set { this.SetValue(ForwardButtonFontStyleProperty, value); }
        }

        public FontStyle CancelButtonFontStyle {
            get { return (FontStyle)this.GetValue(CancelButtonFontStyleProperty); }
            set { this.SetValue(CancelButtonFontStyleProperty, value); }
        }
    }
}