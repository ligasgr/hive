package pl.ligasgr.hive

import swing._
import swing.Swing._

object GuiApplication extends SimpleSwingApplication {

  def top = new MainFrame {
    title = "Sign in"
    contents = new BoxPanel(Orientation.Vertical) {
      border = EmptyBorder(5, 5, 5, 5)
      contents += new Label("Username:")
      contents += new TextField(10)
      contents += new Label("Password:")
      contents += new PasswordField(10)
    }
    centerOnScreen()
  }
}
