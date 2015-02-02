using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Tests
{
    public abstract class EditorConfigTests
    {
        public IEnumerable<string> InFiles(string name)
        {
            return Directory.EnumerateFiles(name, "*.in");
        }

        /*function(new_ec_test name ec_file src_file regex)
    add_test(${name} ${EDITORCONFIG_CMD} -f ${ec_file}
        "${CMAKE_CURRENT_SOURCE_DIR}/${src_file}")
    set_tests_properties(${name} PROPERTIES PASS_REGULAR_EXPRESSION "${regex}")
endfunction()
*/
        public void EcTest(string name, string ecFile, string srcFile, string regex)
        {

        }
    }
}
